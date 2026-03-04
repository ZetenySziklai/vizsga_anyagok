const router = require('express').Router();
const c = require('../controllers/ertekelesController');

router.get('/', c.getAll);
router.get('/robot/:robotId', c.getByRobot);
router.post('/', c.create);
router.put('/:id', c.update);
router.delete('/:id', c.delete);

module.exports = router;
